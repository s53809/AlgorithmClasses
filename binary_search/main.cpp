#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int N, pos, ans;
vector<int> x;

void BS(int str, int end) {
	int mid;
	if ((str + end) % 2 == 0) mid = (str + end) / 2 + 1;
	else mid = (str + end) / 2;
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);
	cout.tie(0);

	cin >> N;
	x.resize(N);
	for (int i = 0; i < N; i++) {
		cin >> x[i];
	}
	sort(x.begin(), x.end());

	cin >> pos;
}