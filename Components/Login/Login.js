import { useState } from 'react';
import './Login.css';
import { Outlet,useNavigate } from 'react-router-dom';


function Login(){
    const [username,setUsername]=useState("");
    const [password,setPassword] = useState("");
    const [loggedin,setLoggedin] = useState(false);
    const [error, setError] = useState("");
    const navigate=useNavigate();
    
    const login =(e)=>{
        e.preventDefault();
        
        if (!username || !password) {
            setError("Username and password are required");
            return;
        }
        
        const user = {
            username: username,
            password: password,
            role: "",
            token: ""
        };

        const requestOptions = {
            method :'POST',
            headers: {'Content-Type':'application/json'},
            body : JSON.stringify(user)
        };

        fetch("http://localhost:5297/api/User/Login", requestOptions)
        .then(res => {
            if (!res.ok) {
                throw new Error("Login failed");
            }
            return res.json();
        })
        .then(res=>{
            sessionStorage.setItem("token",res.token);
            sessionStorage.setItem("username",res.username);
            sessionStorage.setItem("role",res.role);
            alert("Login success - "+res.username);
            navigate('/welcome/'+res.username)
            setLoggedin(true);
        })
        .catch(err=>{
            console.log(err);
            setError("Invalid username or password");
            setLoggedin(false);
        });
    };
    
    return(
        <div>
            {loggedin ? <h2 className='alert alert-success'>Welcome you have successfully logged in - {username}</h2> : null}
            {error && <div className="alert alert-danger">{error}</div>}
            
            <div className='alert alert-primary divlogin'>
                <form>
                    <label className="form-control">Username</label>
                    <input placeholder='username' className="form-control" type="text" value={username} 
                    onChange={(e)=>setUsername(e.target.value)} />
                    <br/>
                    <label className="form-control">Password</label>
                    <input className="form-control" type="password" value={password} 
                    onChange={(e)=>setPassword(e.target.value)}/>
                    <button onClick={login} className="btn btn-success">Login</button>
                    <button type="button" className="btn btn-danger">Cancel</button>
                </form>
            </div>
        </div>
    );
}

export default Login;
