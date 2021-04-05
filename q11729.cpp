//algorithm for hanoi tower

#include<iostream>

void hanoi(int from, int to, int num, int count) {
    ++count;
    if (num == 1) {
        std::cout << count << '\n';
        std::cout << from << to << '\n';
        return;
    }
    hanoi(from, 6 - to - from, --num, count);
    std::cout << from << to << '\n';
    hanoi(6 - to - from, to, num, count);
}

int main() {
    int n, count = 0;
    std::cin >> n;
    hanoi(1, 3, n, count);
    return 0;
}