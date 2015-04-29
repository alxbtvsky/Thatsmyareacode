namespace thatsmyareacode.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using thatsmyareacode.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<thatsmyareacode.Models.ZingerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(thatsmyareacode.Models.ZingerDBContext context)
        {
            context.Zingers.AddOrUpdate(i => i.ZingerID,
                new Zinger
                {
                    ZingerMessage = "I love this site!",
                    ZingerImage = "",
                    ZingerUserName = "Alex",
                    Genre = "Random",
                    AreaCode = "502",
                    UpVote = 1,
                    DownVote = 1,
                    Favorite = true,
                    TimeCreated = DateTime.Now
                },

                new Zinger
                {
                    ZingerMessage = "This picture says otherwise",
                    ZingerImage = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxQHBhUUEhEUFRAXFRoaGRcSFRQWHBgZGRYYGR4YGB4ZHCgiHBomHBUeITEiJSk3Li4wGB8zOjUwNyovLi4BCgoKDg0OGxAQGiwkHyUtLCw1LCwsLCwsLCwsLywvNDQsLCwsLCwsLCw0NDQsLCwsLCwsNCwsMiwsLCwsLCwsLP/AABEIALcBEwMBIgACEQEDEQH/xAAcAAEBAAIDAQEAAAAAAAAAAAAABwYIAwQFAQL/xABAEAABAwIEBAMECAQDCQAAAAABAAIDBBEFBhIhBxMxQSJRYQgUMoEVI2JxcoKRokJSobEzssIWJkNEU3ODksH/xAAWAQEBAQAAAAAAAAAAAAAAAAAAAQL/xAAfEQEAAgICAwEBAAAAAAAAAAAAATERIUFhAkJRMiL/2gAMAwEAAhEDEQA/ALiiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIh2X4ZKHnZwJ9CCg/aIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIi+E2CD6i/DJA/oQfuIK/WrxW7oPqIiAiIgIiIC8DOmbIMoYOZpzcnZkbfikdb4R6eZ7L3lqpxVzC7Ned3hhJjjdyYmg7GzrFw7Xc7v5W8lOlUXJjKzilUvqa2aSLDmOLWQU7nxCR3qQbuaAdzfrcC26+8WMl0+WMvCtw9rqWeJ7ATDI9uprnAefUO0n5Kn5TwcYDlyCnbb6uNoJG13Wu53zdc/NYN7QleKbJDY+8s7B8mgvP9QE8tUkbd3g3nZ+bcDcycg1UBAc7pra6+l5HnsQfu9V08xZdqM8Z6eBUzU9BStbG50Li10sjhrc1m9vCHAFxGx237Y17NVI7nVktvBaNgPmbucf0Fv1VwNoWE7AC5Pb1JKvl9SGsfFZ4y7mj3akqKkNjiZrL6iVxdI4XJPisPCW7ADclUSbhm6oyTHIyrq48QFOHuvUSFj5CwO0uBPh8ri1vVSvDr534pNJF2z1Wog/9Np1WP8A42La4NGm1tk9Vm2FZMw5lNwyh97u8GAzvMpcXDW0vvcm4Ia62xuFB8hifM+coac1FQInvJcBNJtG0FxF9XkLX9VdOM2LDBuH0wGzpbQtA+31t+RrlJeCFczBcTmqJKaql8AjYaaB8wFzqdqLehs1qRuck02IjwqGKj5YiZytrtIuDbub9Tt1O61YhqZsdztyKapnbDLUlsdppTpjLzYi57N33VszTxLjp8uzkUlfG/lua101LJGwOcNLdTjsNyFNPZ+wj37OZmI8NPEXD8b/AAD+hckWTTYLDMFhwyh5TIxpLdLi8l7ni1vG51y7qevmta+JeIuiz/PDRyysjEgYGMlkDddhqDRqs0ajaw2Fls3iVY3D8OklebMjjc8k9g1pcf7LVDKNR9IZ+jnljmlHPM72wRuleSHF/wALdyNVrqXJUNgKDhpTNoWCSSrdLobrd73UC7rC5sH2G6x7CsiTYBxMprVlRNRmOWS0z3OIdG1rNL7WafFK1w27HyuuTMfE12IV8dBSU1RFU1DmM5lRGYjGx7rOc1p3JDQbHYd97WVTjZoYAOgFv0V7Tp4GfmxNylUyStuI4Xua4Etc0220OBBaSQOh3UI4QYfLm3MzmVFRUup44i9wbPK3e4a0XDr9ST8lSfaCxf3HJghB8VRKG/lZ4yfuuGj5rDeD2Y6PJeXZp6p0jZZpLMDYZjrbGOjX6dBOpzv4tu6kXKzTo8R/eeHObmCjrqnlSRiQNklc+3jeNDgdntFttQ7+e6umSsbOYsrQVLmhr5GAuA6agSDb0uNlEqrAK3i/mT3wRiCgI0Mke5ptGxx2DQbueSXHpYdL+d7wTC2YLhMUEQtHEwNbfrsOp9Sdz96sVsm2v3HSpfhedtNPLJE10LHObHI9rdRLhcAGwJturRkbBo6XKEAc3W+SFpkdIS9zy4ajqLtyLnYdAoLx3qefxFlH8kcbf2a/9atuLVkj6Snw6mcW1EkLTLI3/l4A0B0n43WLWDzuegUif5JtB6WaSu4kCmFROKd1cYw1s0v+Hzi2wOq/w91szXPp8EwOR0gaymjjcXi22kDfbuT+pJWsXC2AS8TaVoHhEziL+TGvcP8AKr7MP9ssw6b3w6klu63SeqZ0afOOO9z2L7D+FXjBNunw5yqacPrKjmcyd7nxQyve4U8TnEsZpJI16SLnt087zDjlWfRecGx0r3wgQtL2xSPa3USbWaDYHTboFsYTpHotUqn/AH54qEXuyeqtcH/hNNtj/wBtilzEHGV94Z5cGE5ZgfLqkq3sD3vlc57gXi+luonSA0226qSZmzHPn3iM2h574aHnmENjdpu0Etc53ZznWNr7C42632LA0tt2WrvFHLc2Tc5mePU2KSUzQyt/hdq1lvo5rj07i3qr7EUsmKcLaVmEkUPMpKprfBLDLICXN3bzPF4hcfK9wuhwMgnlwupqKt8klQ6flapnF7tMItbUSTYPe8W8wV6vDHiDHnKg0PsytY36xnQOHTmM82nuO36E5fh2Hx4bAWxizXSSSHe/ike6Rx/9nFKS0Z9oSpbhk9MIHPinfzHPMT3Mu0EW1BpAJLid+uxXe4U5NZj2UGVFXNVOkke/TapnZZjXaejXebSVPuNeKHGOIUrW3cIg2FoG9yN3ADz1OI+Spp4jwZNynDG2hrbxxtjbzoHQMLg3u9/mR2BKkUs26fEDhs+ioxNQ1lW36yNronzSPFnvbHdhvquC65BJ6npZV6mhFPTtYOjWgC++wFl4mRDNNleKWoN6iYGV/YDmEuDQOwa0taPwrIFekvYiIiuOcEwO0/FY2++2y1HyFRe+8QaWN4395aXD8DtRH7Vt2o5nPhfU02ahiGFlhkEglMLyG/WA3OknYhx6gkdTv5SNTkmsLGtcONuNnM2dWUlPeQQ/VhrN9UzneIfKwb6WKplfimOYth5hiw2OjlcyxnkqopA3oDoay5Dutr3suTh1wyiyk/nSv59cb3kINmX6hgO9/tHc+iuNmdPa4eZXGUsrxwbGT45XDvI7r8gLNHo1cHFTF/oTIdTIDZ5Zy22/mkIZcfcCT8llqmPFXLmI5zp44YI4oqdrtbuZN4nutYbNaQGi57m9+1lJ2Rpg/s54R7zmOaoI8MMQaPxSH/41h/VbDKdcI8rVWTsPkhqIozrkD+ZFLq/htZzS0Wtba173PS29AqJHRxXawvd/KCB/U7LUpCG+0ji+qrpqUH4WmZw/ESxv+V39FnfBTCPonIEJIs+YmZ3rr+H9gasCztwzxXNmY5Kl4pmh1g1nOcdDGiwbfRue5PmSrJggkpcFYx8AY+ONrdDHtcDpaB4Tttt3AUjULNpt7RmL+7Zfgpgd5pC5w+zGB/qeP0K7Ps84R7nlF85HinlNj9iO7R+7UvI4j5AxTOuP87TTxxNbojYZiSGgk3cQz4iTew6bDfqaRkSgmwXLENPNC1r4Y9N45A9ryO42BBPU3G1+pSKkl4nG/F/orIEovZ07mwj81y79rSsK9m7B7yVNWRuAIWn77Pf/AGYvb4qZSxLO9RG2KOGOmiuQJJvE5zurjpaQLDYC57+dhy5EwLF8nYJ7uymoZG8xz9RnkaSXADezN/h6+Vk8eSVBxLB2YhidPM62qne9zbtubujLOt9hvf1sFyYTi8WMRvdC7WxjyzWPhc5tr6T/ABAHa/mCphmvA8xZkhdGZaWGB1wY4JHN1C/Rzi0uO2xsQD5LP8Bwt2WMqw08MQkfHGBbWGAv3c5xJvYF5PQHr0QQ72hcY99zgyAG4p4gD6Pks8/t0rKuIWUPc+DFOwN+spQyR1gBu/aTv/NJf8q8av4W4riOaTWStpXOdMJSznOsQHA6L6Olha6teIUf01gMsMsejmxvYW6gbam2uCPv/op6nKXezhi/NwmopSd45BI0fZeA029Lsv8AmVkUR4d8O8TyZmQVGmnfGWmORomIJY4tJ03Z1BaDbva1wrYxxcwEixtuNjb02WpSGq3FCN2KcU6lkbC+R0zGNa3qSI2MsP0WweDYO7BMDnmmcH10zXSTyAWBcGENY3yYxtmj7r914mTMimkzlV4hVMHOfPJyGkg6GEkczYkanA2A6gX87DMsyRPny9UNibqldC8MaCBqcWEAXJAFz5lZn84X2avcLcNqMVzextMdD9L9Utr8pjmljnj7VnEN9SFtPhOHR4Rh0cMTdMUbQ1o67DuT3J6k9yVjXDDJbcm5fDCAaqSzpnjz7MB/lbe3qbnusxWpRjXEbF/oLJVTMDZwiLW9fjf4G9PVyi/s8YR75muSoI8MEW345LtH7Q79VQ+KuXsQzlRMp6eKKOBr9bnSzeJ7gCALNaQGi9+u/kLb/eEWU6rJlLLFUQxnmSB3MilvYBttLmlo2G5uCfiOynj9WaZZX5hbSZtpqM2vPFM+5O949BaB941n8i7WYcEhzFhL4KhgdG8fNp7Oaezh5qdZ0yNiOYs7msp5o6cQBjYHPdcvIbqc6zQQBqcW2d1t0svcfjuNUtLoOERTTaf8WGrjbGXW/kks4eov81Lg5QOGCXJPEZsbX/WQVLW6htraXDqPJzHbj1W12IVjaDDZJX7Mjjc8/c1pcf7KT5S4W1FVmj6QxV7DLzBKIYzfx7ObrI2DWnbSL30je3XMeItDW45gMlLRxRjmeF8ksob4O4aACbnpvays/nByg/DSjOaOJsT3i/1rqh/XbSS8fvLQtmMwYU3HMEmp3kBsrCwkjVa/e3mDuPUKQ5AyBiuSsUfMyKjlL49FnzPFhqB2IZ6LKcdGYcQh0wNoaYEbuZI57/kXssNvS/qnGDnLNIcThjxUUjDeVsWssbuI2CzW6vK99h1NivSWCcKsnzZYop31bw+snku94e592tHhu49TcuPzWdIj6iIiiIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiICIiAiIgIiIP//Z",
                    ZingerUserName = "Ollie",
                    Genre = "Humor",
                    AreaCode = "270",
                    UpVote = 1,
                    DownVote = 1,
                    Favorite = false,
                    TimeCreated = DateTime.Now
                }
           );

        }
    }
}
