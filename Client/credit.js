
let userID = sessionStorage["userId"]; 

async function creditUser() {
  
  let req = await fetch("https://localhost:44339/api/User/"+userID)
  let u = await req.json();

  if (u.TotalActionsToday >= u.MaxActions) {
    alert("Sorry you reached your maximum amount of actions for today!")
    location.href ="../Project1/LogIn.html";
  }
  let obj = {
    FullName:u.FullName,
    UserName :u.UserName,
    Password : u.Password,
    MaxActions:parseInt(u.MaxActions),
    TotalActionsToday:  parseInt(u.TotalActionsToday)+1,
    LastLogin:u.LastLogin
  }
  let fetchParams = {
    method: "PUT",
    body: JSON.stringify(obj),
    headers: {
      "Content-Type": "application/json"
    },
  };

  let resp = await fetch("https://localhost:44339/api/User/" + userID,
    fetchParams)
    sessionStorage["TotalActionsToday"] = parseInt(sessionStorage["TotalActionsToday"])+1 ;
};