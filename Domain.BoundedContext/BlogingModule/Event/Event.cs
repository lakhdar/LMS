namespace Domain.BoundedContext.BlogingModule
{
    using Domain.BoundedContext.ERPModule;
    using Domain.BoundedContext.MembershipModule;
    using Domain.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// Application Event  information  
    /// </summary>
    [Table("Events")]
    public class Event : EntityBase
    {

        #region Properties

        /// <summary>
        /// Get or set News Title
        /// </summary>
        [Required(ErrorMessageResourceName = "EventTitleRequired", ErrorMessageResourceType = typeof(Resources.Messages))]
        public string Title { get; set; }

        /// <summary>
        /// Get or set Event's Date start
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Get or set Event's Date end
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Get or set Event's location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Get or set Event's Description
        /// </summary>
        public string Description { get; set; }

        
        /// <summary>
        /// Get or set associated Address identifier
        /// </summary>

        public Guid? AddressId { get; set; }

        /// <summary>
        /// Get the current associated Address for this event
        /// </summary>
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        /// <summary>
        ///  Get or Set News associated to this  Event  
        /// </summary>
        public virtual ICollection<News> Events { get; set; }

        #endregion
    }

}