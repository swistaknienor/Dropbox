using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChat.ChatApp
{
    public class Message
    {
        public string ID;
        public DateTime Date;
        public MessageStateType MessageState;
        public string Content;
        public MessageType MessageType;
        public DirectionType Direction;

        private Message(string pID, DateTime pDate, MessageStateType pMessageState, string pContent, MessageType pMessageType)
        {

        }

        private void UpdateMessage()
        {

        }

    }
}
