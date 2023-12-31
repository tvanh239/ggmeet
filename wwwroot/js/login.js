//*****************************************************************************
//* File Name    : login.js                                                   *
//* Function     : Action for login and sign up                               *
//* System Name  : Ggmeet                                                     *
//* Create       : VietAnh 2023/12/31                                         *
//* Update       :                                                            *
//* Comment      :                                                            *
//*****************************************************************************
var btn_login = document.getElementById("btnLogin");  // Login/sign Up button



/// 【Check confirm password with password】 VietAnh 2023/12/31 ↓
var confirmPassword = document.getElementById("confirmPassword");
if (confirmPassword != null) {
    confirmPassword.addEventListener("keyup", function () {
        var passwordSignUp = document.getElementById("passwordSignUp");
        if (passwordSignUp != null) {
            if (passwordSignUp.value != (this).value) {
                btn_login.disabled = true;
            } else {
                btn_login.disabled = false;
            }
        }
    });
}
/// 【Check confirm password with password】 VietAnh 2023/12/31 ↑

/// 【Check confirm terms and privacy】 VietAnh 2023/12/31 ↓
var gridCheck = document.getElementById("gridCheck");
if (gridCheck != null) {
    gridCheck.addEventListener("click", function (e) {
        if (e.target.checked) {
            btn_login.disabled = false;
        } else {
            btn_login.disabled = true;
        }
    });
}
/// 【Check confirm terms and privacy】 VietAnh 2023/12/31 ↑