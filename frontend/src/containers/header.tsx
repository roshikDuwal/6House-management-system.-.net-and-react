type Args={
    subtitle:string
}

const Header = ({subtitle}:Args) => {
    return (
        <header className="row mb-4">
            <div className="col-5">
                <h1>Logo</h1>
            </div>
            <div className="col-7 mt-5 subtitle">
                {subtitle}
            </div>
        </header>
    )
}

export default Header