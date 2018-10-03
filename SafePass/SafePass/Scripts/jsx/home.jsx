function GetReact() {
    const elemento = (
            <h1>Bienvenidos a Safe Pass</h1>
    );
    console.log("Render bienvenido" + elemento);
    ReactDOM.render(elemento, document.getElementById('app'));
}
class Welcome extends React.Component {
    render() {
        return <h1>Hello, {this.props.name}</h1>;
    }
}
function Welcome(props) {
    return <h1>Hello, {props.name}</h1>;

    console.log(props.name);
}

const el = <Welcome name="luis" />;
ReactDOM.render(
    el,
    document.getElementById('root')
);