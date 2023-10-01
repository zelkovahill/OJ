#include <iostream>

using namespace std;

int check(int n) 
{
    string numstr = to_string(n);
    if (numstr.find('7') == string::npos && n % 7 != 0)
        return 0;
    else if (numstr.find('7') == string::npos && n % 7 == 0)
        return 1;
    else if (numstr.find('7') != string::npos && n % 7 != 0)
        return 2;
    else //if (numstr.find('7') != string::npos && n % 7 == 0)
        return 3;
}

int main() 
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);

    int n;
    cin >> n;

    int result = check(n);
    cout << result << "\n";

    return 0;
}
