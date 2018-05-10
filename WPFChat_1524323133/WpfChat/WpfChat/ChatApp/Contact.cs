using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChat.ChatApp
{
   public class Contact
    {
        public string Nickname;
        public int ID;
        public byte[] ProfileImage;
        public List<Message> MessageList;
        public Dictionary<int, Contact> ContactDic;
        public UserStateType ContactState;

        private Contact()
        {

        }

        private void AddMessage()
        {

        }

        private void DeleteMessage()
        {

        }

        private void GetMessage()
        {

        }

        private void UpdateContactInfo()
        {

        }

    }
}
