public class Solution {
    public string DefangIPaddr(string address) {
        string defangedAddress = address.Replace(".", "[.]");
        return defangedAddress;
    }
}