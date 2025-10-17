using assignSeven.interfaces;
using System.Drawing;

namespace assignSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Icircle circle = new circle(5);
            //IRectangle rectangle = new rectangle(4, 6);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion
            #region q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "admin";
            //string password = "12345";
            //string role = "Administrator";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"User authenticated: {isAuthenticated}");

            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"User authorized for role '{role}': {isAuthorized}"); 
            #endregion
            #region q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("john@example.com", "Welcome to our service!");
            //smsService.SendNotification("+201001234567", "Your OTP code is 123456.");
            //pushService.SendNotification("User123", "You have a new message!"); 
            #endregion
        }
    }
}
