public class Solution {
    public string GenerateTheString(int n) {
    if (n % 2 == 0)
        return new string('a', n - 1) + 'b';
    else
        return new string('a', n);
}
}