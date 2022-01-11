function sweetsalty()
{
    var num_sweets=0;
    var num_sweetnsalts=0;
    var num_salts=0;
    var output = new Array();
    console.log("idiot");
      //  let shit = document.createElement('h5');
        let title = document.createElement('h3');
        document.body.appendChild(title);
        title.innerText = "Sweet and Salty Interactive"
        let introbutton = document.createElement('button');
        let resumebutton = document.createElement('button');
        let counterbutton = document.createElement('button');
        let userinput = document.createElement('input');
        let secondaryuserinput = document.createElement('input');
        document.body.appendChild(introbutton);
        introbutton.innerText = "Click to proceed";
        let primary=0;
        let secondary=0;
        let instructiontext = document.createElement('h3');



                                                                    //Credit to robert sharp for helping me with this code
        introbutton.addEventListener('click', (e)=>
        {
           // document.body.innerHTML = ' ';
            instructiontext.innerText = 'Enter first number';
            
            document.body.appendChild(userinput);
            document.body.appendChild(resumebutton);
            resumebutton.innerText = 'click to proceed';
        })
        
        resumebutton.addEventListener('click', (e)=>
        {   
            primary=userinput.value;
            instructiontext.innerText = 'Enter Secondary Number';
            //   secondaryuserinput= document.createElement('input');
            document.body.appendChild(secondaryuserinput);
            document.body.appendChild(counterbutton);
            counterbutton.innerText = 'Click to start Calculation';
            
        })
        counterbutton.addEventListener('click', (e)=>
        {
            secondary=secondaryuserinput.value;
            console.log(primary,secondary);
            console.log("this fired");
            for (var i = primary; i <= secondary; i++)
            
            {
                
                
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                   // title.innerText= output.toString();
                    
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
                    //  title.innerText= output.toString();
                    //  document.appendChild(title);
                    // console.log("Sweet ");
                    num_sweets++;
                }
                
                else 
                {
                    output.push(i + " ");
                    //  title.innerText= output.toString();
                    //  document.appendChild(title);
                    // console.log(i + " ");
                }
                if (output.length == 40 || i==secondary)
                {
                    title=document.createElement('h5');
                    document.body.appendChild(title);
                    title.innerText= output.toString();
                    // console.log(output.toString());
                    output= [];
                    
                    // console.log()
                }
            }
            console.log("     ");
            console.log(`Number of Sweet's : ${num_sweets}`);
            console.log(`Number of Salty's : ${num_salts}`);
            console.log(`Number of Sweet 'n Salty's ${num_sweetnsalts}`);
            
            
        })
        console.log(primary);
        console.log(secondary);
        console.log(userinput);
        console.log(secondaryuserinput);
        console.log(`${userinput}`);
        console.log(`${secondaryuserinput}`);
        

    
}

sweetsalty();




























