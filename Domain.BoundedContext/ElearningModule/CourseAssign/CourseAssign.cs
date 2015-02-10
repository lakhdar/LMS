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
    /// Application CourseAssign  information  
    /// </summary>
    [Table("CourseAssign")]
    public class CourseAssign : EntityBase
    {

        #region Properties

        /// <summary>
        /// Get or set  Student Id  
        /// </summary>
   
        public Guid StudentId { get; set; }
        /// <summary>
        ///  Get or set the studed assigned in course 
        /// </summary>
       [ForeignKey("StudentId")]
        public virtual User Student { get; set; }

        /// <summary>
        /// Get or set  Course Id  
        /// </summary>
       
        public Guid CourseId { get; set; }
        /// <summary>
        ///  Get or Set the assigned course to user 
        /// </summary>
         [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        #endregion
    }

}