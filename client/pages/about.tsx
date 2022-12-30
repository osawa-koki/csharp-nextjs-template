import Link from 'next/link'
import Layout from '../components/Layout'

const AboutPage = () => (
  <Layout title="Nextjsテンプレートについて。">
    <h1>About</h1>
    <p>This is the about page</p>
    <ul>
      <li>api/{name} (GET)</li>
      <li>api/{name} (POST)</li>
      <li>api/{name} (PUT)</li>
      <li>api/{name} (DELETE)</li>
    </ul>
  </Layout>
)

export default AboutPage
