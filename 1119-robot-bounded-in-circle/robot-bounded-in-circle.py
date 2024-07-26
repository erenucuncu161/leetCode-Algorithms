class Solution(object):
    def isRobotBounded(self, instructions):
        """
        :type instructions: str
        :rtype: bool
        """
        yon=(0,1)
        x,y=0,0
        for i in instructions:
            if i=="G":
                x,y=x+yon[0],y+yon[1]
            if i=="L":
                yon=(-yon[1],yon[0])
            if i=="R":
                yon=(yon[1],-yon[0])

            
        return(x==0 and y==0) or yon!=(0,1)
        