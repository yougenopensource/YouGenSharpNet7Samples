/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202958 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.Net;
using System.Security.Cryptography;
using System.Text;
namespace XE_HR_BackEndCommon.Services;
public class EncryptionDecryptionService : IEncryptionDecryptionService
{
    private readonly Byte[] _key;
    private readonly Aes _aes;
    private readonly ICryptoTransform _encryptor;
    private readonly ICryptoTransform _decryptor;
    public EncryptionDecryptionService(String encryptDecryptKey)
    {
        _key = Encoding.UTF8.GetBytes(encryptDecryptKey);
        _aes = Aes.Create();
        _aes.Key = _key;
        _aes.IV = new Byte[16];
        _encryptor = _aes.CreateEncryptor();
        _decryptor = _aes.CreateDecryptor();
    }
    public String? EncStr(String? input)
    {
        if (String.IsNullOrEmpty(input))
            return null;
        Byte[] array;
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, _encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                {
                    streamWriter.Write(input);
                }
                array = memoryStream.ToArray();
            }
        }
        return Convert.ToBase64String(array);
    }
    public String? EncByte(Byte input)
    {
        return EncStr(input.ToString());
    }
    public String? EncInt16(Int16 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt16(UInt16 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncInt32(Int32 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt32(UInt32 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncInt64(Int64 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt64(UInt64 input)
    {
        return EncStr(input.ToString());
    }
    public String? EncDecimal(Decimal input)
    {
        return EncStr(input.ToString());
    }
    public String? EncSingle(Single input)
    {
        return EncStr(input.ToString());
    }
    public String? EncDouble(Double input)
    {
        return EncStr(input.ToString());
    }
    // nullables
    public String? EncByteNullable(Byte? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncInt16Nullable(Int16? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt16Nullable(UInt16? input)
    {        return EncStr(input.ToString());
    }
    public String? EncInt32Nullable(Int32? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt32Nullable(UInt32? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncInt64Nullable(Int64? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncUInt64Nullable(UInt64? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncDecimalNullable(Decimal? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncSingleNullable(Single? input)
    {
        return EncStr(input.ToString());
    }
    public String? EncDoubleNullable(Double? input)
    {
        return EncStr(input.ToString());
    }
    public String? DecStr(String? input)
    {
        if (String.IsNullOrEmpty(input))
            return null;
        Byte[] buffer = Convert.FromBase64String(input);
        using (MemoryStream memoryStream = new MemoryStream(buffer))
        {
            using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, _decryptor, CryptoStreamMode.Read))
            {
                using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
    public Byte DecByte(String? input)
    {
        return Convert.ToByte(DecStr(input));
    }
    public Int16 DecInt16(String? input)
    {
        return Convert.ToInt16(DecStr(input));
    }
    public UInt16 DecUInt16(String? input)
    {
        return Convert.ToUInt16(DecStr(input));
    }
    public Int32 DecInt32(String? input)
    {
        return Convert.ToInt32(DecStr(input));
    }
    public UInt32 DecUInt32(String? input)
    {
        return Convert.ToUInt32(DecStr(input));
    }
    public Int64 DecInt64(String? input)
    {
        return Convert.ToInt64(DecStr(input));
    }
    public UInt64 DecUInt64(String? input)
    {
        return Convert.ToUInt64(DecStr(input));
    }
    public Decimal DecDecimal(String? input)
    {
        return Convert.ToDecimal(DecStr(input));
    }
    public Single DecSingle(String? input)
    {
        return Convert.ToSingle(DecStr(input));
    }
    public Double DecDouble(String? input)
    {
        return Convert.ToDouble(DecStr(input));
    }
    // nullables
    public Byte? DecByteNullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToByte(DecStr(input));
    }
    public Int16? DecInt16Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToInt16(DecStr(input));
    }
    public UInt16? DecUInt16Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToUInt16(DecStr(input));
    }
    public Int32? DecInt32Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToInt32(DecStr(input));
    }
    public UInt32? DecUInt32Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToUInt32(DecStr(input));
    }
    public Int64? DecInt64Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToInt64(DecStr(input));
    }
    public UInt64? DecUInt64Nullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToUInt64(DecStr(input));
    }
    public Decimal? DecDecimalNullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToDecimal(DecStr(input));
    }
    public Single? DecSingleNullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToSingle(DecStr(input));
    }
    public Double? DecDoubleNullable(String? input)
    {
        return String.IsNullOrEmpty(input) ? null : Convert.ToDouble(DecStr(input));
    }
    public String? CreateHash(String? input)
    {
        if (String.IsNullOrEmpty(input))
            return null;
        using (SHA256 sha256Hash = SHA256.Create())
        {
            Byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (Int32 i = 0; i < bytes.Length; i++)
                builder.Append(bytes[i].ToString("x2"));
            return builder.ToString();
        }
    }
}
