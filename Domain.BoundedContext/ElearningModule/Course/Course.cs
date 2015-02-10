namespace Domain.BoundedContext.ElearningModule
{
    using Domain.BoundedContext.BlogingModule;
    using Domain.BoundedContext.MembershipModule;
    using Domain.Core;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// Application Course  information  
    /// </summary>
    [Table("Courses")]
    public class Course : EntityBase
    {

        #region Properties

        /// <summary>
        /// Get or set Course Name
        /// </summary>
        [Required(ErrorMessageResourceName = "CourseNameRequired", ErrorMessageResourceType = typeof(Resources.Messages))]
        public string Name { get; set; }

        /// <summary>
        /// Get or set Course Desciption
        /// </summary>
        public string Desciption { get; set; }

        /// <summary>
        /// Get or set Course Level
        /// </summary>
        public CourseLevel Level { get; set; }

        /// <summary>
        /// Get or set Course Mode
        /// </summary>
        public CourseMode Mode { get; set; }

        
        /// <summary>
        /// Get or Set Events associated with this Course 
        /// </summary>
        public virtual ICollection<Event> Events { get; set; }

        /// <summary>
        /// Get or Set Assigned users to the course 
        /// </summary>
        public virtual ICollection<CourseAssign> Assignments { get; set; }

        #endregion
    }

}