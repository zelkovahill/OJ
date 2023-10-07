#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cout.tie(0);
    cin.tie(0);

while (true)
    {
        string n;
        cin >> n;

        if (n == "CU")
            cout << "see you\n";
        else if (n == ":-)")
            cout << "I’m happy\n";
        else if (n == ":-(")
            cout << "I’m unhappy\n";
        else if (n == ";-)")
            cout << "wink\n";
        else if (n == ":-P")
            cout << "stick out my tongue\n";
        else if (n == "(~.~)")
            cout << "sleepy\n";
        else if (n == "TA")
            cout << "totally awesome\n";
        else if (n == "CCC")
            cout << "Canadian Computing Competition\n";
        else if (n == "CUZ")
            cout << "because\n";
        else if (n == "TY")
            cout << "thank-you\n";
        else if (n == "YW")
            cout << "you’re welcome\n";
        else if (n == "TTYL") 
        {
            cout << "talk to you later\n";
            break;
        }
        else
            cout << n << "\n";
    }
   


}