//*****************************************************************************
//* File Name    : User.cs                                                    *
//* Function     : User Model                                                 *
//* System Name  : Ggmeet                                                     *
//* Create       : VietAnh 2023/12/28                                         *
//* Update       :                                                            *
//* Comment      :                                                            *
//*****************************************************************************
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ggmeet.Models
{
    /// <summary>
    /// Account for the user
    /// </summary>
    public class User
    {
        #region properties

        /// <summary>The code of user</summary>
        public int Id { get; set; }
		/// <summary>The name of user</summary>
		

		[StringLength(60, MinimumLength = 1)]
		[Required(ErrorMessage = "必要")]
		public string? Name { get; set; }


		/// <summary>the email of user</summary>
		[Required(ErrorMessage = "必要")]
		[EmailAddress(ErrorMessage = "有効なメールアドレスを入力してください")]
		public required string Email { get; set; }


		/// <summary>The password of user</summary>
		[Required(ErrorMessage = "必要")]
		[StringLength(int.MaxValue, MinimumLength = 4, ErrorMessage = "4桁以上入力してください")]
		public required string Password { get; set; }


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

        /// <summary>The salt password of user</summary> 
        public string? SaltPassword { get; set; }
        #endregion

        #region Functions

        #endregion

    }
}
