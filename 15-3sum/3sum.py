class Solution(object):
    def threeSum(self,nums):
        nums.sort()  
        dizi = []
    
        for i in range(len(nums) - 2):
            if i > 0 and nums[i] == nums[i - 1]: 
                continue
            
            left, right = i + 1, len(nums) - 1
            while left < right:
                toplam = nums[i] + nums[left] + nums[right]
                if toplam == 0:
                    dizi.append([nums[i], nums[left], nums[right]])
                    while left < right and nums[left] == nums[left + 1]:
                        left += 1
                    while left < right and nums[right] == nums[right - 1]:
                        right -= 1
                    left += 1
                    right -= 1
                elif toplam < 0:
                    left += 1
                else:
                    right -= 1
            
        return dizi
    
                       
        

                        
                






        