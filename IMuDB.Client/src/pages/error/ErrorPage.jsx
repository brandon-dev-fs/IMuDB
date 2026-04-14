import classes from './ErrorPage.module.css'

function ErrorPage() {
    return <article className="page">
        <section className="content">
            <h1 className={classes.error_page_message}>
                404 Error
            </h1>
        </section>
    </article>;
}

export default ErrorPage