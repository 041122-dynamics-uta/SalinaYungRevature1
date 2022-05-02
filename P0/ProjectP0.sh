#!/bin/bash

choiceFunc () {
echo Would you like to add, subtract, multiply, or divide?
read action1
if [[ $action1 == add || $action1 == subtract || $action1 == multiply || $action1 == divide ]]
then
	echo Enter first number.
	read n1
	echo Enter second number.
	read n2
	resultFunc
else 
	echo Invalid choice. Please choose from list.
	choiceFunc
fi
}

#calculator functions
addFunc () {
	addResult=$((n1 + n2))	
}

subtractFunc () {
	subtractResult=$((n1 - n2))
}

multiplyFunc () {
	multiplyResult=$((n1 * n2))
}

divideFunc () {
	divideResult=$((n1 / n2))
}

#result function
resultFunc () {
if [[ $action1 == add ]]
 then 
	addFunc
	echo The sum is: $addResult
 elif [[ $action1 == subtract ]]
 then
	subtractFunc
	echo The difference is: $subtractResult
 elif [[ $action1 == multiply ]]
 then 
	multiplyFunc
	echo The product is: $multiplyResult
 elif [[ $action1 == divide ]]
 then 
	divideFunc
	echo The quotient is: $divideResult
 fi
}

#loop
while True;
do

#present choices function
# choiceFunc () {
# echo Would you like to add, subtract, multiply, or divide?
# read action1
# if [[ $action1 == add || $action1 == subtract || $action1 == multiply || $action1 == divide ]]
# then
# 	echo Enter first number.
# 	read n1
# 	echo Enter second number.
# 	read n2
# 	resultFunc
# else 
# 	echo Invalid choice. Please choose from list.
# 	choiceFunc
# fi
# }

# #calculator functions
# addFunc () {
# 	addResult=$((n1 + n2))	
# }

# subtractFunc () {
# 	subtractResult=$((n1 - n2))
# }

# multiplyFunc () {
# 	multiplyResult=$((n1 * n2))
# }

# divideFunc () {
# 	divideResult=$((n1 / n2))
# }

# #result function
# resultFunc () {
# if [[ $action1 == add ]]
#  then 
# 	addFunc
# 	echo The sum is: $addResult
#  elif [[ $action1 == subtract ]]
#  then
# 	subtractFunc
# 	echo The difference is: $subtractResult
#  elif [[ $action1 == multiply ]]
#  then 
# 	multiplyFunc
# 	echo The product is: $multiplyResult
#  elif [[ $action1 == divide ]]
#  then 
# 	divideFunc
# 	echo The quotient is: $divideResult
#  fi
# }

#begin program
echo Hello, what is your name?
read user
echo Welcome $user!

choiceFunc

echo Would you like to continue? y or n?
read action2

#exit
if [[ $action2 != "y" ]]
then 
	exit
fi
done
