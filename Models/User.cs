//*****************************************************************************
//* File Name    : User.cs                                                    *
//* Function     : User Model                                                 *
//* System Name  : Ggmeet                                                     *
//* Create       : VietAnh 2023/12/28                                         *
//* Update       :                                                            *
//* Comment      :                                                            *
//*****************************************************************************

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
        public string? Name { get; set; }
        /// <summary>the email of user</summary>
        public required string Email { get; set; }
        /// <summary>The password of user</summary>
        public required string Password { get; set; }
        /// <summary>The phone of user</summary>
        public required string Phone { get; set; }
        /// <summary>Birthdate of user</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>The status of user</summary> 
        /// false : This account is working, true : This account is deleted
        public bool IsDelete { get; set; }
        /// false : The created date of the account
        public DateTime? CreateDate { get; set; }
        #endregion

        #region Functions

        #endregion

    }
}
