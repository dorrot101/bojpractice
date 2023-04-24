#include<iostream>
#include<vector>

std::vector<std::vector<char>> map;

void star(int length) {
    if (length == 1) return;

    int unit = length / 3;

    for (int i = unit; i < map.size(); i += length) {
        for (int j = unit; j < map.size(); j += length) {
            for (int xpos = i; xpos < i + unit ; xpos++ ) {
                for (int ypos = j; ypos < j + unit ; ypos++) {
                    map[xpos][ypos] = ' ';
                }
            }
        }
    }

    star(length / 3);
}

int main() {
    int input;
    std::cin >> input;
    map.resize(input, std::vector<char>(input, '*'));
    star(input);
    for (int i = 0; i < input; i ++) {
        for (int j = 0; j < input; j ++) {
            std::cout << map[i][j];
        }
        std::cout << '\n';
    }
    return 0;
}