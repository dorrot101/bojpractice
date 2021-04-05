//algorithm for hanoi tower

#include<iostream>

int getnum(int n) {
    if (n == 1) return 1;
    return 2 * getnum(n - 1) + 1;
}

void hanoi(int from, int to, int num) {
    if (num == 1) {
        std::cout << from << ' ' << to << '\n';
        return;
    }
    hanoi(from, 6 - to - from, --num);
    std::cout << from << ' ' << to << '\n';
    hanoi(6 - to - from, to, num);
}

int main() {
    int n;
    int count = 0;
    std::cin >> n;
    std::cout<<getnum(n)<<'\n';
    hanoi(1, 3, n);
    return 0;
}