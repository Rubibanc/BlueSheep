









// Generated on 12/11/2014 19:01:46
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GuildFightJoinRequestMessage : Message
    {
        public new const uint ID =5717;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int taxCollectorId;
        
        public GuildFightJoinRequestMessage()
        {
        }
        
        public GuildFightJoinRequestMessage(int taxCollectorId)
        {
            this.taxCollectorId = taxCollectorId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteInt(taxCollectorId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            taxCollectorId = reader.ReadInt();
        }
        
    }
    
}