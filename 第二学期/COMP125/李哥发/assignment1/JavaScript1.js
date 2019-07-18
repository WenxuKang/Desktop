//JavaScript Source Code


    function Calculate()
        {
            
            var e = document.getElementById("gender");
            var gender = e.options[e.selectedIndex].value;

            var age = document.getElementById("age").value;

            var height = document.getElementById("height").value;

            var unit = document.getElementById("heightUnit");
            var heightUnit = unit.options[unit.selectedIndex].value;

            var weight = document.getElementById("weight").value;

            var wUnit = document.getElementById("weightUnit");

            var weightUnit = wUnit.options[wUnit.selectedIndex].value;

            var level1 = document.getElementsByName('RadioActivity');
            for (var i = 0, length = level1.length; i < length; i++) {
                if (level1[i].checked) {
                    var level = level1[i].value;

                    break;
                }
            }

            if (gender == "Female" && heightUnit == "cm" && weightUnit == "Kg")
            {
                var first = 9.563 * weight;
                var second = 1.850 * height;
                var third = 4.676 * age;
                var total = 655.1 + first + second - third;
                var calories = total * level;
                //alert(calories);
            }
            else if (gender == "Male" && heightUnit == "cm" && weightUnit == "Kg")
            {
                var first = 13.75 * weight;
                var second = 5.003 * height;
                var third = 6.755 * age;
                var total = 66.5 + first + second - third;
                var calories = total * level;
                //alert(calories);
            }
            else if (gender == "Female" && heightUnit == "inches" && weightUnit == "LBs")
            {
                var first = 4.35 * weight;
                var second = 4.7 * height;
                var third = 4.7 * age;
                var total = 655.1 + first + second - third;
                var calories = total * level;
                //alert(calories);
            }
            else if (gender == "Male" && heightUnit == "inches" && weightUnit == "LBs")
            {
                var first = 6.2 * weight;
                var second = 12.7 * height;
                var third = 6.76 * age;
                var total = 66 + first + second - third;
                var calories = total * level;
                //alert(calories);
            }

            if(calories<=1500)
            {
            	
            document.getElementById("BMRResult1").innerHTML = calories.toFixed(2);
            }
            
            else if( calories>=1500 && calories<=2500)
            {
            	document.getElementById("BMRResult2").innerHTML = calories.toFixed(2);
            }
            
            else if( calories>2500)
            {
            	document.getElementById("BMRResult3").innerHTML = calories.toFixed(2);
            }


        }
        document.getElementById("convert").
            addEventListener("click", Calculate, false);

 