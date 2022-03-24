#include <iostream>
#include <vector>
using namespace std;

int N;
vector<int> x;

void swap(int a,int b) {
	int temp = x[a];
	x[a] = x[b];
	x[b] = temp;
}

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
	for (int i = 0; i < N - 1; i++) {
		int leastNum = i;
		for (int j = i + 1; j < N; j++) {
			if (x[leastNum] > x[j]) {
				leastNum = j;
			}
		}
		if (leastNum != i) swap(i, leastNum);
	}
	cout << "정렬 후 : ";
	print();
}