using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {

        private readonly IServiceProvider _serviceProvider;
        Context context = new();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {

                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için teşekkürler. Dergilerimize websitemizden ulaşabilirsiniz."

            }) ;
            context.SaveChanges();
        }
    }
}
