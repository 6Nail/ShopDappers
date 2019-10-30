using Shop.Services.Abstract;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Shop.Services
{
    public class SmsRegistration : IRegistration
    {
        private static Random random = new Random();
        public int verificationCode { get; private set; }

        public void Register(string mobileNumber)
        {
            verificationCode = random.Next(1000, 10000);
            const string accountSid = "AC61ec6b4768cca686cceff1e85ba028d4";
            const string authToken = "165e4bedc94ce14bc0254f0e278f4add";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"Your verification code: {verificationCode}",
                from: new Twilio.Types.PhoneNumber("+13342747989"),
                to: new Twilio.Types.PhoneNumber("+77075141968")
            );

            if(CheckCode(verificationCode)){

            }
        }

        public bool CheckCode(int code)
        {
            return code == int.Parse(Console.ReadLine());
        }
    }
}
