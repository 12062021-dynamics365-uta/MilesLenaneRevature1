function sweetsalty()
{
    console.log("idiot");
        
        var num_salts=0;
        var num_sweets=0;
        var num_sweetnsalts=0;
        var output = new Array();
        for (var i = 1; i < 1001; i++)
        {
          

            if (i % 20 == 0)
            {

               console.log(output.toString());
               output= [];
               
                 // console.log()
            }

            if (i % 3 == 0 && i % 5 == 0)
            {
                output.push("Sweet and Salty ");
              //  console.log("Sweet and Salty ");
                num_sweetnsalts++;

            }

            else if (i % 5 == 0)
            {
                output.push("Salty ");
               // console.log("Salty ");
                num_salts++;
            }

            else if (i%3==0)
            {
                output.push("Sweet ")
               // console.log("Sweet ");
                num_sweets++;
            }

            else 
            {
                output.push(i + " ");
              // console.log(i + " ");
            }
        }

       
        console.log("     ");
        console.log(`Number of Sweet's : ${num_sweets}`);
        console.log(`Number of Salty's : ${num_salts}`);
        console.log(`Number of Sweet 'n Salty's ${num_sweetnsalts}`);


    
}

sweetsalty();




























