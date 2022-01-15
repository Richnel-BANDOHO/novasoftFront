using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace novaSoft.Models
{
    public class Message
    {
		public long messageId { get; set; }
		[DataType(DataType.MultilineText)]
		public string messageContent { get; set; }
		public DateTime createdAt { get; set; }
		public long senderId { get; set; }
		public long receiverId { get; set; }
		public DateTime seenDate { get; set; }
		public Boolean isModified { get; set; }
		public int modificationNum { get; set; }
	}
}