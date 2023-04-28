#include<iostream>
using namespace std;
int main() {
    int hour, minute, changetominute, alarmed;
    cin >> hour;
    cin >> minute;
    changetominute = hour * 60 + minute;
    alarmed = changetominute - 45;
    if (alarmed < 0) {
        alarmed += 1440;
    }
    cout << alarmed / 60 << " " << alarmed % 60;
    return 0;
}