using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Training20251231.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Training20251231.Controllers
{

    public class Auth : Attribute, IAuthorizationFilter
    {
        public static SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("anscahcoiancqvuqkl szkjcbuqawfkolqawnfoiqwqqw3"));
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var header = context.HttpContext.Request.Headers.Authorization.ToString();

                header = header.Replace("Bearer ", "");
                header = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoie1wiSWRcIjoxMDA1LFwiRW1haWxcIjpcInN0cmluZ1wifSJ9.R6hGMHxNVDcVUbGoVaNOLubD-Kt4R8JFD3rUolbE830";
                var token = new JwtSecurityTokenHandler().ValidateToken(header,
                    new TokenValidationParameters()
                    {
                        ValidateLifetime = false,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        IssuerSigningKey = key,

                    }, out _);

                var claims = token.Claims.FirstOrDefault() ?? throw new Exception();
                var user = JsonSerializer.Deserialize<User>(claims.Value);
                var user2 = new LyonSession4DbContext().Users.Include(x => x.Addresses).FirstOrDefault(x => x.Id == user.Id) ?? throw new Exception();
                context.HttpContext.Items["user"] = user2;
            }
            catch (Exception ex)
            {

                context.Result = new UnauthorizedResult();
            }
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        public LyonSession4DbContext db = new LyonSession4DbContext();

        private string hashed(string str)
        {
            var sha = SHA256.Create();

            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(str));


            return string.Concat(bytes.Select(x => x.ToString("x2")));
        }

        [HttpPost("/api/register")]
        public object register(User user)
        {
            if (db.Users.ToList().Any(x => x.Email == user.Email))
            {
                return Conflict();
            }

            user.Password = hashed(user.Password);
            user.SecurityAnswer = hashed(user.SecurityAnswer);
            db.Users.Add(user);

            db.SaveChanges();
            var token = new JwtSecurityToken(claims: new[]
                {
                    new Claim("user", JsonSerializer.Serialize(new {user.Id, user.Email}))
                },
                    signingCredentials: new SigningCredentials(Auth.key, SecurityAlgorithms.HmacSha256)
                );


            return new { token = new JwtSecurityTokenHandler().WriteToken(token) };
        }

        [HttpPost("/api/login")]
        public object login(Dictionary<string, string> req)
        {
            try
            {
                var user = db.Users.FirstOrDefault(x =>
                    x.Email == req["email"] &&
                    x.Password == hashed(req["password"])
                ) ?? throw new Exception();

                var token = new JwtSecurityToken(claims: new[]
                {
                    new Claim("user", JsonSerializer.Serialize(new {user.Id, user.Email}))
                },
                    signingCredentials: new SigningCredentials(Auth.key, SecurityAlgorithms.HmacSha256)
                );


                return new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            }
            catch (Exception ex)
            {

                return Unauthorized();
            }
        }

        [HttpPost("/api/forgot-password")]
        public object forgot(Dictionary<string, string> req)
        {

            try
            {
                var user = db.Users.FirstOrDefault(x =>
                    x.Email == req["email"]
                ) ?? throw new Exception();

                return new { user.SecurityQuestion };


            }
            catch (Exception ex)
            {

                return Unauthorized();
            }
        }
        [HttpPost("/api/reset-password")]
        public object reset(Dictionary<string, string> req)
        {

            try
            {
                var user = db.Users.FirstOrDefault(x =>
                    x.Email == req["email"]
                    && x.SecurityAnswer == hashed(req["answer"])
                ) ?? throw new Exception();

                if (req.TryGetValue("password", out var password))
                {
                    user.Password = hashed(password);
                    db.SaveChanges();
                    return Ok();

                }


                return NoContent();



            }
            catch (Exception ex)
            {

                return Unauthorized();
            }
        }

        [HttpGet("/api/profile")]
        [Auth]
        public User Get()
        {
            var item = HttpContext.Items["user"] as User;
            return item;
            //   return new Address[] { "value1", "value2" };
        }
        [HttpPut("/api/profile")]
        [Auth]
        public object updateprofile(User user)
        {

            var item = HttpContext.Items["user"] as User;
            if (item.Id != user.Id) return BadRequest();

            if (db.Users.ToList().Any(x => x.Email == user.Email && x.Id != item.Id))
            {
                return Conflict();
            }
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return item;
            //   return new Address[] { "value1", "value2" };
        }
        [HttpPut("/api/subscribe")]
        [Auth]
        public object subscribe()
        {

            var item = HttpContext.Items["user"] as User;

            item.MailingListSubscription = true;
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();

        }
        [HttpPut("/api/unsubscribe")]
        [Auth]
        public object unsubscribe()
        {

            var item = HttpContext.Items["user"] as User;

            item.MailingListSubscription = false;
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();

        }


        // GET: api/<AddressesController>
        [HttpGet]
        [Auth]
        public IEnumerable<Address> Gett()
        {
            var item = HttpContext.Items["user"] as User;
            return item.Addresses;
            //   return new Address[] { "value1", "value2" };
        }


        // POST api/<AddressesController>
        [HttpPost]
        [Auth]
        public object Post([FromBody] Address value)
        {
            var item = HttpContext.Items["user"] as User;

            db.Entry(item).State = EntityState.Modified;

            value.UserId = item.Id;
            item.Addresses.Add(value);
            db.SaveChanges();
            return value;
        }

        // PUT api/<AddressesController>/5
        [HttpPut("{id}")]
        [Auth]
        public object Put(int id, [FromBody] Address value)
        {

            var item = HttpContext.Items["user"] as User;
            db.Entry(item).State = EntityState.Modified;

            if (id != value.Id) return BadRequest();
            var addr = item.Addresses.FirstOrDefault(x => x.Id == value.Id);

            if (addr == null) return BadRequest();

            db.Entry(addr).CurrentValues.SetValues(value);
            db.SaveChanges();
            return value;
        }

        // DELETE api/<AddressesController>/5
        [HttpDelete("{id}")]
        [Auth]
        public object Delete(int id)
        {
            try
            {
                var item = HttpContext.Items["user"] as User;

                var value = item.Addresses.FirstOrDefault(x => x.Id == id) ?? throw new Exception();
                db.Remove(value);
                db.SaveChanges();

                return value;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        //private async Task buttononclick()
        //{
        //    var req = await helper.post();

        //    var token = req.token;

        //    helper.addBearerToken(token);

        //    helper.client.DefaultRequestHeaders.Clear();
        //    helper.client.DefaultRequestHeaders.Add("Authorization","token");
        //    var address = helper.get < List<Address>("url");

        //}
    }
}
