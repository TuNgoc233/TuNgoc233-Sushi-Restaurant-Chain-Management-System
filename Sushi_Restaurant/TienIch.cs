using System.Security.Cryptography;
using System.Text;

public static class SecurityUtils
{
    // Hàm băm mật khẩu
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();

            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2")); // Chuyển byte thành chuỗi hex
            }
            return builder.ToString();
        }
    }
}
