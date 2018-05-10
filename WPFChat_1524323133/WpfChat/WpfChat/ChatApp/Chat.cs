using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChat.ChatApp
{
    public class Chat
    {
        public Action<User> OnUserLogin;
        public Action OnUserLogout;
        public Action OnUserRegister;

        private User              _User = null;
        private MessageController _MessageController = null;
        private ContactController _ContactController = null;

        /*property skrateny zapis*/
        public User User => _User;
        /*public User ExampleUser
         {
           get {return _User;}
         }*/

        public Chat()
        {
            _MessageController = new MessageController(this);
            _ContactController = new ContactController(this);
        }


        private void Register()
        {
            OnUserRegister?.Invoke();
        }

        private void Login()
        {
            OnUserLogin?.Invoke(_User);
        }

        private void Logout()
        {
            _User = null;
            OnUserLogout?.Invoke();
        }

        #region MessageController methods

        public void SendMessage(Message pMessage)
        {
            _MessageController.SendMessage(pMessage);
        }

        public void ReceiveMessage(Message pMessage)
        {
            _MessageController.ReceiveMessage(pMessage);
        }

        public void DeleteMessage(Message pMessage)
        {
            _MessageController.DeleteMessage(pMessage);
        }

        #endregion
    }
}
