var jwt = require("jsonwebtoken");


///// User TOKEN
var token = jwt.sign({
	"UserName" : "mertoztekin",
	"ChannelName" : "Web",
	"Culture" : "tr-TR",
	"TimeZone" : "Europe/Berlin",
	"exp" : (new Date).getTime()
	},
	'YOUR SECRET KEY',
	{
		headers:{
			"ApiKey" : "YOUR API KEY"
			}
	});

console.log(token);



///// Admin TOKEN
var token = jwt.sign({
        "AdminUserName" : "mertoztekin",
        "ChannelName" : "Web",
        "Culture" : "tr-TR",
        "AdminTimeZone" : "Europe/Berlin",
        "exp" : (new Date).getTime()
        },
        'YOUR SECRET KEY',
        {
                headers:{
                        "ApiKey" : "YOUR API KEY"
                        }
        });

console.log(token);


