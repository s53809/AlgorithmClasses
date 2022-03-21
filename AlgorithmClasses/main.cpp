#include <iostream>
#include <vector>
using namespace std;

int N;
vector<int> x;
bool isSwaping = false;

void swap(int a, int b) {
	int box = x[a];
	x[a] = x[b];
	x[b] = box;
}

int main() {
	cin >> N;
	x.resize(N);
	for (int i = 0; i < N; i++)
		cin >> x[i];

	for (int i = 0; i < N; i++) {
		for (int j = 1; j < N - i; j++) {
			if (x[j - 1] > x[j]) {
				isSwaping = true;
				swap(j - 1, j);
			}
		}
		if (!isSwaping) break;
	}

	for (int i = 0; i < N; i++)
		cout << x[i] << ' ';
}