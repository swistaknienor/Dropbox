using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WpfChat.ChatApp
{   
    [System.Serializable]
    public struct UserInfoData
    {
        public string          _Nickname;
        public int             _ID;
        public string          _Email;
        public string          _PhoneNumber;
        public UserStateType   _UserStateType;

        [System.NonSerialized]
        public object _ProfileImage;
    }

    public class User
    {
        private UserInfoData _UserInfoData;
   
        public List<Contact>              _ContactList = new List<Contact>();
        public Dictionary<int, Contact>   _ContactDic  = new Dictionary<int, Contact>();
        public UserStateType _UserState;

        public UserInfoData UserInfoData { get => _UserInfoData; set => _UserInfoData = value; }

        private User()
        {

        }

        private void AddContact(Contact pContact)
        {
            _ContactList.Add(pContact);
            _ContactDic.Add(0, pContact);
        }

        private void DeleteContact(Contact pContact)
        {
            _ContactList.Remove(pContact);
            _ContactDic.Remove(0, pContact);
        }

        private void GetContacts()
        {

        }

        private void UpdateUserInfo()
        {

        }
    }
}
