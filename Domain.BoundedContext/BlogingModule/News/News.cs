namespace Domain.BoundedContext.BlogingModule
{
    using Domain.BoundedContext.MembershipModule;
    using Domain.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// Application News  information  
    /// </summary>
    [Table("News")]
    public class News : EntityBase
    {

        #region Properties

        /// <summary>
        /// Get or set News Title
        /// </summary>
        [Required(ErrorMessageResourceName = "NewsTitleRequired", ErrorMessageResourceType = typeof(Resources.Messages))]
        public string Title { get; set; }

        /// <summary>
        /// Get or set News Body
        /// </summary>
        [DataType(DataType.Html)]
        public string Body { get; set; }

        /// <summary>
        /// Get or set News Summary
        /// </summary>
        [DataType(DataType.Html)]
        public string Summary { get; set; }

        /// <summary>
        /// Get or set News Image url 
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Get or set News Body
        /// </summary>
        [DataType(DataType.Url)]
        public string Video { get; set; }

        /// <summary>
        /// Get or Set Events associated with this news 
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        #endregion
    }

}