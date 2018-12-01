#include<cstdio>
int n, a[2187][2187], r[3];
int f(int x, int y, int l) {
    int ck = 0, c = a[x][y];
    if (l == 1) {
        r[c + 1]++;
        return c;
    }
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            int t = f(x + l / 3 * i, y + l / 3 * j, l / 3);
            if (t == 2 || c^t) ck = 1;
        }
    }
    if (!ck) r[c + 1] -= 8;
    return ck ? 2 : c;
}
int main() {
    scanf("%d", &n);
    for (int i = 0; i < n; i++) for (int j = 0; j < n; j++) scanf("%d", a[i] + j);
    f(0, 0, n);
    printf("%d\n%d\n%d", r[0], r[1], r[2]);
    return 0;
}