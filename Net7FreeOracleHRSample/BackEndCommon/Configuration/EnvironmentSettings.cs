/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202757 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
namespace XE_HR_BackEndCommon.Configuration;
public class EnvironmentSettings
{
    public String? RuntimeEnvironment { get; set; }
    public String? MachineName { get; set; }
    public CustomAppSettings CustomAppSettingsOverrides { get; set; } = new CustomAppSettings();
}
