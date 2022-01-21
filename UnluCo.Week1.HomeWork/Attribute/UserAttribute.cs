using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using UnluCo.Week1.HomeWork.DBOperations;

namespace UnluCo.Week1.HomeWork.Attribute
{

    public class UserAttribute : ActionFilterAttribute
    {


        public override void OnActionExecuting(ActionExecutingContext context)
        { /*OnActionExecuting metodu override edilip attribute’un tanımlandığı action çağırılmadan önce yetki kontrollerimizi yapar*/
            base.OnActionExecuting(context);
            User valUser = (User)context.ActionArguments["valUser"]; //Eylemin iptali sırasında geçecek bağımsız değişkenleri alır. Anahtarlar parametre adlarıdır.

            bool result = Valid(valUser);  //Action çalışmadan önce burası çalışır

            if (result != true)
            {
                context.Result = new ContentResult()
                { };
                return;
            }

        }

        public bool Valid(User valUser)  
        {
            var user = DataGenerator.Userz.SingleOrDefault(x => x.UserEmail == valUser.UserEmail); //D.Generator'deki pmetreler ile yeni girilenler karşılaştırılıyor.

            if (user is null)
            {
                throw new InvalidOperationException("E-mail veya parola yanlış");
            }

            if (user.UserEmail == valUser.UserEmail && user.UserPassword == valUser.UserPassword) //Kontrolün yapıldığı kısım
            {
                return true;
            }
            return false;
        }

    }
}