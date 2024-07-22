class Solution(object):
    def judgeCircle(self, moves):
        """
        :type moves: str
        :rtype: bool
        """
        ustalt=0
        sagsol=0
        
        for i in moves:
            if i =="U":
                ustalt=ustalt+1           
            if i =="D":
                ustalt=ustalt-1
            if i =="R":
                sagsol=sagsol+1
            if i =="L":
                sagsol=sagsol-1
        
        if(sagsol==0 and ustalt==0):
            return True
        else:
             return False
        

    