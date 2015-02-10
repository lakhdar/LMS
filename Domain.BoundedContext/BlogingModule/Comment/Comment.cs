namespace Domain.BoundedContext.BlogingModule
{
    using Domain.BoundedContext.MembershipModule;
    using Domain.Core;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// Application Comment  information  
    /// </summary>
    [Table("Comments")]
    public class Comment : EntityBase
    {

        #region Properties

        /// <summary>
        /// Get or set Comment Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Get or set Comment Body
        /// </summary>
        [Required(ErrorMessageResourceName = "CommentBodyRequired", ErrorMessageResourceType = typeof(Resources.Messages))]
        [DataType(DataType.Html)]
        public string Body { get; set; }

        /// <summary>
        /// Get or set  Publisher Id  
        /// </summary>
       
        public Guid PublisherId { get; set; }
        /// <summary>
        ///     User   for the Publisher who published this Comment
        /// </summary>
        [ForeignKey("PublisherId")]
        public virtual User Publisher { get; set; }

        /// <summary>
        /// Get or Set Events associated news  id
        /// </summary>
      
        public Guid NewsId { get; set; }
        /// <summary>
        ///  Get or Set Events associated news  
        /// </summary>
        [ForeignKey("NewsId")]
        public virtual News News { get; set; }

        #endregion
    }

}