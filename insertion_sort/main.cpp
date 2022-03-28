#include <iostream>
#include <vector>
using namespace std;

int N;
vector<int> x;

void print() {
	for (int i = 0; i < N; i++) {
		cout << x[i] << ' ';
	}
	cout << '\n';
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);
	cout.tie(0);
	freopen("input.txt", "r", stdin);

	cin >> N;

	x.resize(N);

	for (int i = 0; i < N; i++) {
		cin >> x[i];
	}

	cout << "정렬 전 : ";
	print();
	int i, j;

	for (i = 1; i < N; i++) {
		int box = x[i];
		for (j = i - 1; j >= 0; j--) {
			if (box > x[j]) break;
			x[j + 1] = x[j];
		}
		x[j + 1] = box;
	}

	cout << "정렬 후 : ";
	print();
	return 0;
}