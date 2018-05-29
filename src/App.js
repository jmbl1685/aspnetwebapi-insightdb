import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {

  constructor() {
    super();
    this.state = {
      launchList: []
    }
  }

  componentDidMount() {
    this.getLunchList();
  }

  getLunchList() {
    fetch('http://40.114.38.57:9700/_api/Application.WebApi/api/launch')
      .then(res => res.json())
      .then(res => {
        this.setState({ launchList: res })
      })
      .catch(err => console.log(err))
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        {
          this.state.launchList.map(data => {

            const ingredients = data.ingredient.split(';')
            const images = data.image.split(';')

            return <div key={data._id}>
              <h1>{data.name}</h1>
              <p>{data.description}</p>
              <h4>Ingredients</h4>
              {
                ingredients.map( (ingredient,i) => {
                  return <ul key={i}>
                    <li >{ingredient}</li>
                  </ul>
                })
              }
              {
                images.map( (images,i) => {
                  return <img key={i} src={images} height="300" width="300"/>
                })
              }
            </div>
          })
        }
      </div>
    );
  }
}

export default App;
