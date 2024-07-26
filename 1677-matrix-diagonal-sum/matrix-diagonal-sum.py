class Solution(object):
    def diagonalSum(self, mat):
        a=len(mat)-1
        sum1=0
        for i in range(len(mat)):
            sum1+=mat[i][i]
            sum1+=mat[a-i][i]
            if a-i==i:
                sum1-=mat[i][i]
        return sum1
            