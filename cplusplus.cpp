#include<iostream>
using namespace std;

int main()
{

    long sum = 0;
    for(int i = 0; i <= 1000000000; i++)
    {
        sum += i;
    }

    cout << sum << endl;
    return 0;
}
