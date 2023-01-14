public class Solution {
    public string DefangIPaddr(string address) {
        
			StringBuilder strbuilder = new StringBuilder(address);
		return strbuilder.Replace(".", "[.]").ToString();
    }
}