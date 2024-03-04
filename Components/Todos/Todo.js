import { useState } from 'react';
import './Todo.css';

function Todo() {
    const [todos, setTodos] = useState([]);
    const fetchClick = () => {
        fetch("https://jsonplaceholder.typicode.com/todos/1")
            .then(res => res.json())
            .then(res => {
                setTodos(prevTodos => [...prevTodos, res]);
            })
            .catch(err => console.log(err));
    };

    return (
        <div>
            <button onClick={fetchClick}>Call Todo</button>
        
            {todos.map(todo =>
                <div key={todo.userid}> 
                    <h2>Id:{todo.id}</h2>
                    <br />
                    Title:{todo.title}
                    <br />
                    Status:<button className='btn btn-success' disabled={!todo.completed}>Go</button>
                </div>
            )}
        </div>
    );
}

export default Todo;
