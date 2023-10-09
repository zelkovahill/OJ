#include <iostream>

using namespace std;

int p1, p2, p3, p4;
int x, y, r;

int main()
{
	ios::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	cin >> p1 >> p2 >> p3 >> p4;
	cin >> x >> y >> r;
    
	if (p1 == x) cout << 1 << endl;
	else if (p2 == x) cout << 2 << endl;
	else if (p3 == x) cout << 3 << endl;
	else if (p4 == x) cout << 4 << endl;
	else cout << 0 << endl;
}