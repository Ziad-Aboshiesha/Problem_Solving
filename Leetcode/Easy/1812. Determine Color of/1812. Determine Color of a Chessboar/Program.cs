public class Solution {
    public bool SquareIsWhite(string coordinates) {
        char temp = coordinates[0];
        int num = coordinates[1];
        if(((int) temp %2 != 0 && num%2 != 0)||((int) temp %2 == 0 && num%2 == 0) )
        {
                return false;
        }
        return true;
    }
}