import { useParams } from "react-router-dom";

function Welcome(){
    var {un}=useParams();
    var divStyle={
        backgroundColor:"yellow",
        width:"30%",
        height:"400px"
    }
    return(
        
        <div style={divStyle}>
            Hello
            <h1 className="alert alert-success"> Hello-{un}</h1>
        </div>
    );

}
export default Welcome;