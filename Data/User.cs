//*****************************************************************************
//* File Name    : User.cs                                                    *
//* Function     : User Model                                                 *
//* System Name  : Ggmeet                                                     *
//* Create       : VietAnh 2023/12/28                                         *
//* Update       :                                                            *
//* Comment      :                                                            *
//*****************************************************************************
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ggmeet.Data
{
    /// <summary>
    /// Account for the user
    /// </summary>
    public class User : IdentityUser
    {
        #region properties


        [StringLength(60, MinimumLength = 1)]
        [Required(ErrorMessage = "必要")]
        public string? Name { get; set; }


        /// <summary>The phone of user</summary>
        [Required(ErrorMessage = "必要")]
        [RegularExpression(@"^\d{10,}$", ErrorMessage = "10桁以上入力してください")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "10 ～ 15 桁")]
        public required string Phone { get; set; }


        /// <summary>Birthdate of user</summary>
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "必要")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }


        /// <summary>The status of user</summary> 
        /// false : This account is working, true : This account is deleted
        public bool IsDelete { get; set; }

        /// <summary>The status of user</summary> 
        ///   The created date of the account
        public DateTime? CreateDate { get; set; }


        #endregion

        #region Functions

        #endregion

    }
}
