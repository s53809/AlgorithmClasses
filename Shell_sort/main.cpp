#include <iostream>
#include <vector>
using namespace std;

vector<int> x;
int N, D;

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
	D = N;
	int i, j;
	cout << "정렬 전 : ";
	print();
	while (D != 1) {
		if (D % 2 == 1) D = D / 2 + 1;
		else D = D / 2;
		for (i = D; i < N; i++) {
			int box = x[i];
			for (j = i - D; j >= 0; j -= D) {
				if (box > x[j]) break;
				x[j + D] = x[j];
			}
			x[j + D] = box;
			cout << D << ": ";
			print();
		}
	}
	cout << "정렬 후 : ";
	print();
}